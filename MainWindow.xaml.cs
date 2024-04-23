using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week_4_Day_6_Lists_key_topic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        //How do we Declare a list

        //Array declaration : type[]


        //List declaration ; List<type>

        //List<CustomError> errors = new List<CustomError>();

        //2a : Declared - Initialized in Constructor


        List<CustomError> errors;
        public MainWindow()
        {
            InitializeComponent();
            //2b: Inititalized

            //This creates an empty list of size 10
            //you can pass in an int to declare a different size

            errors = new List<CustomError>();

            //If a refrence object is not initialized, it is null
            // null means there is no object in memory

            //adding an object to yout list

            //call the list name  , then the .add(object)method
            //add() is alwyas added to the end of the list
            //index 0
            errors.Add(new CustomError("Err02", "Format exception"));

            errors.Add(new CustomError("Err03", "Divide By Zero"));

            //runErrorMessages.Text = errors[0].ToString();

            //Insert(index, object)
            //list.Insert(1, new object)
            //Allowing you to insert an object at an specific index
            errors.Insert(1, new CustomError("err04","IndexOutOfbounds" ));

            //-------------------Removing Items from the list

            //Remove(object)
            //Removes an objectt by refrencei=ing the memory address of an object
            //CustomError objecToRemove = errors[0];
            //errors[0] = (objecToRemove);

            //RemoveAt(Index)
            //removes an object  by index on the list

            errors.RemoveAt(1);

            //Clear
            errors.Clear();

            //Accessing Elements -----------------------------  

            // You Can access an element the sdame way as an array
            //use square brackets [index]
            CustomError currentElement = errors[1];
            runErrorMessages.Text = errors[1].ToString();


            //Tell if an object exists
            //contains (object)

            MessageBox.Show(errors.Contains(currentElement).ToString());

            //runErrorrMessages.Text = errors[0].ToString();



            CustomError ce = new CustomError(  "Error",  "Invalid password-Not enough characters");


            //How to add something to a list
            //Adding : listName.Add(object);

            errors.Add(ce);//Adding instance of our custom Error

            //ce.ErrorMessage = "I changed this";

            //We access elements in a lsit the same way as we do an array 
            //using square brackets

            //Error code - Error Message
            //runErrorMessages.Text = $"{errors[0].ErrorCode}-{errors[0].ErrorMessage}";

            CustomError myError = ce;

            runErrorMessages.Text = $"{ce.ErrorCode}{ce.ErrorMessage}";

            runErrorMessages.Text = ce.ToString() ;



            DisplayErrors(errors);

        }

        public void DisplayErrors(List<CustomError> errors)
        {
            runErrorMessages.Text = "";

            foreach(CustomError error in errors)
            {
                runErrorMessages.Text += error ;
            }
        }

    }
}