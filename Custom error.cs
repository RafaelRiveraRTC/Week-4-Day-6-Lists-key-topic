using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Day_6_Lists_key_topic
{
    public class CustomError
    {

        //fields
        //Error code-message

        string _errorCode;
        string _errorMessage;



        //constructors

        public CustomError(string errorCode, string errorMessage)
        {
            _errorCode = errorCode;
            _errorMessage = errorMessage;
        }


        //properties
        public string ErrorCode { get => _errorCode; }

        public string ErrorMessage { get => _errorMessage;}

        //new: override ToString()
        // This will allow us to change what displays
        // when we  call the ToString() on instanced 

        public override string ToString()
        {
            return $"{this.ErrorCode} {this.ErrorMessage}";
        }



    }//main

}// namespace
