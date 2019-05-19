using System;
using System.Collections.Generic;

namespace SingletonPattern.Models
{
    public class RegisterNote
    {
        private static RegisterNote _registerNote = new RegisterNote();
        public List<string> Histories { get; set; } = new List<string>();

        // Make Constructor private
        private RegisterNote() { }

        public static RegisterNote GetInstance() => _registerNote;
    }
}
