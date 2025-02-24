using System;

namespace TP2
{
    class Age
    {
        public void Ages(DateTime birthday)
        {
            DateTime now = DateTime.Now;

            int yearsOfAge = now.Year - birthday.Year;
            int difMonth = now.Month - birthday.Month;
            int difDays = now.Day - birthday.Day;


            if (now.Month < birthday.Month)
            {
                yearsOfAge--;
            }
            else if (now.Month == birthday.Month && now.Day < birthday.Day)
            {
                yearsOfAge--;
            }

            if (difMonth < 0)
            {
                difMonth += 12;
            }

            if (difDays < 0)
            {
                DateTime dateLastMonth = now.AddMonths(-1);
                difDays += DateTime.DaysInMonth(dateLastMonth.Year, dateLastMonth.Month);
                difMonth--;
            }

            Console.WriteLine($"Você possui {yearsOfAge} anos, {difMonth} meses e {difDays} dias.");

        }
        public void Ages(DateTime birthday, string name)
        {
            DateTime now = DateTime.Now;

            DateTime birthdayThisYear = new DateTime(now.Year, birthday.Month, birthday.Day);

            if (birthdayThisYear > now)
            {
                TimeSpan remainingDays = birthdayThisYear - now;
                Console.WriteLine($" Seu aniversário será ainda este ano e faltam {remainingDays.Days} dias para chegar, {name}!");
            }
            else
            {
                DateTime birthdayNextYear = new DateTime(now.Year + 1, birthday.Month, birthday.Day);
                TimeSpan remainingDays = birthdayNextYear - now;
                Console.WriteLine($" Seu aniversário será no próximo ano e faltam {remainingDays.Days} dias para chegar, {name}!");
            }

        }

        public void DifDate(DateTime CFirstDate, DateTime CSecondDate)
        {

            int difYear = (int)(CSecondDate.Year - CFirstDate.Year);
            int difMonth = (int)(CSecondDate.Month - CFirstDate.Month);
            int difDay = (int)(CSecondDate.Day - CFirstDate.Day);

            TimeSpan totalDifInDays = CSecondDate - CFirstDate;
            int CTotalDifInDays = Math.Abs(totalDifInDays.Days);

            if (difDay < 0)
            {
                difMonth--;
                difDay += DateTime.DaysInMonth(CSecondDate.Year, CSecondDate.Month);
            }
            if (difMonth < 0)
            { 
                difMonth += 12;
                difYear--;
            }

            if (CFirstDate < CSecondDate)
            {
                Console.WriteLine();
                Console.WriteLine("Primeira data é menor que a segunda");
                Console.WriteLine($"Diferença: {difYear} anos, {difMonth} meses, {difDay} dias.");
                Console.WriteLine($"Total de dias: {CTotalDifInDays} dias.");
            }
            else if (CFirstDate > CSecondDate)
            {
                Console.WriteLine();
                Console.WriteLine("A primeira data é maior que a segunda");
                Console.WriteLine($"Diferença: {difYear} anos, {difMonth} meses, {difDay} dias.");
                Console.WriteLine($"Total de dias: {CTotalDifInDays} dias.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("As duas datas são iguais.");
            }

        }
    
    }
}