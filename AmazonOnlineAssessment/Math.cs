using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOnlineAssessment
{
    public static class RandomicNumber
    {

        public static int Get(int inicialNumber, int maxNumber)
        {
            Random random = new Random();
            return random.Next(inicialNumber, maxNumber);
        }

    }
}
