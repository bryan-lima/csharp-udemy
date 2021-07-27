using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace section4.exercises
{
    class Student
    {
        public double MINIMUM_NOTE = 60.0;

        public string Name;
        public double FirstTrimesterNote;
        public double SecondTrimesterNote;
        public double ThirdTrimesterNote;

        public double FinalNote()
        {
            return FirstTrimesterNote + SecondTrimesterNote + ThirdTrimesterNote;
        }

        public bool IsApproved()
        {
            if (FinalNote() >= MINIMUM_NOTE) return true;
            
            return false;
        }

        public double DifferenceForApproval()
        {
            return MINIMUM_NOTE - FinalNote();
        }

        public override string ToString()
        {
            return "NOTA FINAL = " + FinalNote().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
