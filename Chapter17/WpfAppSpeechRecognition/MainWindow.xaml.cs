using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Speech.Recognition;
using System.Globalization;
namespace WpfAppSpeechRecognition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static bool completed;
        private void buttonSpeech_Click(object sender, RoutedEventArgs e)
        {
            using (SpeechRecognitionEngine recognizer =
         new SpeechRecognitionEngine(new CultureInfo("en-US")))
            {

                // Create and load the exit grammar.  
                Grammar exitGrammar = new Grammar(new GrammarBuilder("exit"));
                exitGrammar.Name = "Exit Grammar";
                recognizer.LoadGrammar(exitGrammar);

                // Create and load the dictation grammar.  
                Grammar dictation = new DictationGrammar();
                dictation.Name = "Dictation Grammar";
                recognizer.LoadGrammar(dictation);

                // Attach event handlers to the recognizer.  
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(
                    SpeechRecognizedHandler);
                recognizer.RecognizeCompleted +=
                  new EventHandler<RecognizeCompletedEventArgs>(
                    RecognizeCompletedHandler);

                // Assign input to the recognizer.  
                recognizer.SetInputToDefaultAudioDevice();

                // Begin asynchronous recognition.  
                Console.WriteLine("Starting recognition...");
                completed = false;
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                // Wait for recognition to finish.  
                while (!completed)
                {
                    System.Threading.Thread.Sleep(333);
                }
                Console.WriteLine("Done.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static void SpeechRecognizedHandler(
      object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("  Speech recognized:");
            string grammarName = "<not available>";
            if (e.Result.Grammar.Name != null &&
              !e.Result.Grammar.Name.Equals(string.Empty))
            {
                grammarName = e.Result.Grammar.Name;
            }
            Console.WriteLine("    {0,-17} - {1}",
              grammarName, e.Result.Text);

            if (grammarName.Equals("Exit Grammar"))
            {
                ((SpeechRecognitionEngine)sender).RecognizeAsyncCancel();
            }
        }

        static void RecognizeCompletedHandler(
          object sender, RecognizeCompletedEventArgs e)
        {
            Console.WriteLine("  Recognition completed.");
            completed = true;
        }
        void ABC()
        {
            // Create an in-process speech recognizer for the en-US locale.  
            using (
            SpeechRecognitionEngine recognizer =
              new SpeechRecognitionEngine(
                new System.Globalization.CultureInfo("en-US")))
            {

                // Create and load a dictation grammar.  
                recognizer.LoadGrammar(new DictationGrammar());

                // Add a handler for the speech recognized event.  
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.  
                recognizer.SetInputToDefaultAudioDevice();

                // Start asynchronous, continuous speech recognition.  
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                // Keep the console window open.  
                while (true)
                {
                    Console.ReadLine();
                }
            }
        }
        // Handle the SpeechRecognized event.  
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("Recognized text: " + e.Result.Text);
        }
    }
}
