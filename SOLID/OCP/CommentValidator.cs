using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class CommentValidator
    {
        // OLD IMPLEMENTATION

        // This is an old implementation. In future if I need to use third party spam validators, using this approach I have to change the existing implementation.
        // Doing so I'll be violating the OCP principle. 

        /*
        public void AddComment(string comment, string ip)
        {
            if (ValidateNotSpam(ip))
            {
            }
        }

        private bool ValidateNotSpam(string ip)
        {
            if (ip == "")
                return false;

            return true;
        }
        */

        // NEW IMPLEMENTATION
        // 1. Use an interface for Comment Validator
        // 2. 

        private ICommaneValidator[] _commentValidator;
        public CommentValidator(ICommaneValidator[] validators)
        {
            _commentValidator = validators;
        }

        private bool ValidateNotSpam(string ip, string comment)
        {
            foreach(var validator in _commentValidator)
            {
                if (!validator.Validate(ip, comment))
                    return false;
            }
            return true;
        }
    }

    public class HoneyPotCommentValidator : ICommaneValidator
    {
        public bool Validate(string authorIP, string comment)
        {
            // Check if author ip is blacklisted and return true/false
            return true;
        }
    }

    public interface ICommaneValidator
    {
        bool Validate(string authorIP, string comment);
    }
}
