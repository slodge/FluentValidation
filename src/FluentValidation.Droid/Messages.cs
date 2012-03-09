using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FluentValidation.Resources
{
    public class Messages
    {
        public static string CreditCardError
        {
            get
            {
                return "'{PropertyName}' is not a valid credit card number.";
            }
        }

        public static string email_error
        {
            get
            {
                return "'{PropertyName}' is not a valid email address.";
            }
        }
        public static string equal_error
        {
            get
            {
                return "'{PropertyName}' should be equal to '{PropertyValue}'.";
            }
        }
        public static string exact_length_error
        {
            get
            {
                return "'{PropertyName}' must be {MaxLength} characters in length. You entered {TotalLength} characters.";
            }
        }
        public static string exclusivebetween_error
        {
            get
            {
                return "'{PropertyName}' must be between {From} and {To} (exclusive). You entered {Value}.";
            }
        }
        public static string greaterthan_error
        {
            get
            {
                return "'{PropertyName}' must be greater than '{ComparisonValue}'.";
            }
        }
        public static string greaterthanorequal_error
        {
            get
            {
                return "'{PropertyName}' must be greater than or equal to '{ComparisonValue}'.";
            }
        }
        public static string inclusivebetween_error
        {
            get
            {
                return "'{PropertyName}' must be between {From} and {To}. You entered {Value}.";
            }
        }
        public static string length_error
        {
            get
            {
                return "'{PropertyName}' must be between {MinLength} and {MaxLength} characters. You entered {TotalLength} characters.";
            }
        }
        public static string lessthan_error
        {
            get
            {
                return "'{PropertyName}' must be less than '{ComparisonValue}'.";
            }
        }
        public static string lessthanorequal_error
        {
            get
            {
                return "'{PropertyName}' must be less than or equal to '{ComparisonValue}'.";
            }
        }
        public static string notempty_error
        {
            get
            {
                return "'{PropertyName}' should not be empty.";
            }
        }
        public static string notequal_error
        {
            get
            {
                return "'{PropertyName}' should not be equal to '{PropertyValue}'.";
            }
        }
        public static string notnull_error
        {
            get
            {
                return "'{PropertyName}' must not be empty.";
            }
        }
        public static string predicate_error
        {
            get
            {
                return "The specified condition was not met for '{PropertyName}'.";
            }
        }
        public static string regex_error
        {
            get
            {
                return "'{PropertyName}' is not in the correct format.";
            }
        }
    }
}