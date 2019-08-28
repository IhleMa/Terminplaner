using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace Terminplaner.Pages
{
    /// <summary>
    /// Interaction logic for MonthView.xaml
    /// </summary>
    public partial class MonthView : Page
    {
        DateTime date = DateTime.Now;

        public MonthView()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            loadCurrentMonth();
        }

        private void loadCurrentMonth()
        {
            DateTime previousMonth = new DateTime(date.Year, date.Month - 1, DateTime.DaysInMonth(date.Year, date.Month));
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime nextMonth = new DateTime(date.Year, date.Month + 1, 1);
            int CW = getIsoWeek(date) % 100;
            int i = 0;
            Brush color = Brushes.Gray;

            weekOneTextBox.Text = "CW " + CW.ToString();
            weekTwoTextBox.Text = "CW" + (CW + 1).ToString();
            weekThreeTextBox.Text = "CW" + (CW + 2).ToString();
            weekFourTextBox.Text = "CW" + (CW + 3).ToString();
            weekFiveTextBox.Text = "CW" + (CW + 4).ToString();

            switch (firstDayOfMonth.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dayOneDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    dayTwoDateTextBox.Text = firstDayOfMonth.AddDays(1).Day.ToString();
                    dayThreeDateTextBox.Text = firstDayOfMonth.AddDays(2).Day.ToString();
                    dayFourDateTextBox.Text = firstDayOfMonth.AddDays(3).Day.ToString();
                    dayFiveDateTextBox.Text = firstDayOfMonth.AddDays(4).Day.ToString();
                    daySixDateTextBox.Text = firstDayOfMonth.AddDays(5).Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.AddDays(6).Day.ToString();
                    break;
                case DayOfWeek.Tuesday:
                    i = 1;

                    dayOneDateTextBox.Text = previousMonth.Day.ToString();
                    dayOneGrid.Background = color;
                    dayTwoDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    dayThreeDateTextBox.Text = firstDayOfMonth.AddDays(1).Day.ToString();
                    dayFourDateTextBox.Text = firstDayOfMonth.AddDays(2).Day.ToString();
                    dayFiveDateTextBox.Text = firstDayOfMonth.AddDays(3).Day.ToString();
                    daySixDateTextBox.Text = firstDayOfMonth.AddDays(4).Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.AddDays(5).Day.ToString();
                    break;
                case DayOfWeek.Wednesday:
                    i = 2;

                    dayOneDateTextBox.Text = (previousMonth.Day - 1).ToString();
                    dayOneGrid.Background = color;
                    dayTwoDateTextBox.Text = previousMonth.Day.ToString();
                    dayTwoGrid.Background = color;
                    dayThreeDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    dayFourDateTextBox.Text = firstDayOfMonth.AddDays(1).Day.ToString();
                    dayFiveDateTextBox.Text = firstDayOfMonth.AddDays(2).Day.ToString();
                    daySixDateTextBox.Text = firstDayOfMonth.AddDays(3).Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.AddDays(4).Day.ToString();
                    break;
                case DayOfWeek.Thursday:
                    i = 3;

                    dayOneDateTextBox.Text = (previousMonth.Day - 2).ToString();
                    dayOneGrid.Background = color;
                    dayTwoDateTextBox.Text = (previousMonth.Day - 1).ToString();
                    dayTwoGrid.Background = color;
                    dayThreeDateTextBox.Text = previousMonth.Day.ToString();
                    dayThreeGrid.Background = color;
                    dayFourDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    dayFiveDateTextBox.Text = firstDayOfMonth.AddDays(1).Day.ToString();
                    daySixDateTextBox.Text = firstDayOfMonth.AddDays(2).Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.AddDays(3).Day.ToString();
                    break;
                case DayOfWeek.Friday:
                    i = 4;
                    
                    dayOneDateTextBox.Text = (previousMonth.Day - 3).ToString();
                    dayOneGrid.Background = color;
                    dayTwoDateTextBox.Text = (previousMonth.Day - 2).ToString();
                    dayTwoGrid.Background = color;
                    dayThreeDateTextBox.Text = (previousMonth.Day - 1).ToString();
                    dayThreeGrid.Background = color;
                    dayFourDateTextBox.Text = previousMonth.Day.ToString();
                    dayFourGrid.Background = color;
                    dayFiveDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    daySixDateTextBox.Text = firstDayOfMonth.AddDays(1).Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.AddDays(2).Day.ToString();
                    break;
                case DayOfWeek.Saturday:
                    i = 5;

                    dayOneDateTextBox.Text = (previousMonth.Day - 4).ToString();
                    dayOneGrid.Background = color;
                    dayTwoDateTextBox.Text = (previousMonth.Day - 3).ToString();
                    dayTwoGrid.Background = color;
                    dayThreeDateTextBox.Text = (previousMonth.Day - 2).ToString();
                    dayThreeGrid.Background = color;
                    dayFourDateTextBox.Text = (previousMonth.Day - 1).ToString();
                    dayFourGrid.Background = color;
                    dayFiveDateTextBox.Text = previousMonth.Day.ToString();
                    dayFiveGrid.Background = color;
                    daySixDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.AddDays(1).Day.ToString();
                    break;
                case DayOfWeek.Sunday:
                    i = 6;

                    dayOneDateTextBox.Text = (previousMonth.Day - 5).ToString();
                    dayOneGrid.Background = color;
                    dayTwoDateTextBox.Text = (previousMonth.Day - 4).ToString();
                    dayTwoGrid.Background = color;
                    dayThreeDateTextBox.Text = (previousMonth.Day - 3).ToString();
                    dayThreeGrid.Background = color;
                    dayFourDateTextBox.Text = (previousMonth.Day - 2).ToString();
                    dayFourGrid.Background = color;
                    dayFiveDateTextBox.Text = (previousMonth.Day - 1).ToString();
                    dayFiveGrid.Background = color;
                    daySixDateTextBox.Text = previousMonth.Day.ToString();
                    daySixGrid.Background = color;
                    daySevenDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    break;
                default:
                    break;
            }

            dayEightDateTextBox.Text = firstDayOfMonth.AddDays(7 - i).Day.ToString();
            dayNineDateTextBox.Text = firstDayOfMonth.AddDays(8 - i).Day.ToString();
            dayTenDateTextBox.Text = firstDayOfMonth.AddDays(9 - i).Day.ToString();
            dayElevenDateTextBox.Text = firstDayOfMonth.AddDays(10 - i).Day.ToString();
            dayTwelveDateTextBox.Text = firstDayOfMonth.AddDays(11 - i).Day.ToString();
            dayThirteenDateTextBox.Text = firstDayOfMonth.AddDays(12 - i).Day.ToString();
            dayFourteenDateTextBox.Text = firstDayOfMonth.AddDays(13 - i).Day.ToString();
            dayFifteenDateTextBox.Text = firstDayOfMonth.AddDays(14 - i).Day.ToString();
            daySixteenDateTextBox.Text = firstDayOfMonth.AddDays(15 - i).Day.ToString();
            daySeventeenDateTextBox.Text = firstDayOfMonth.AddDays(16 - i).Day.ToString();
            dayEighteenDateTextBox.Text = firstDayOfMonth.AddDays(17 - i).Day.ToString();
            dayNineteenDateTextBox.Text = firstDayOfMonth.AddDays(18 - i).Day.ToString();
            dayTwentyDateTextBox.Text = firstDayOfMonth.AddDays(19 - i).Day.ToString();
            dayTwentyoneDateTextBox.Text = firstDayOfMonth.AddDays(20 - i).Day.ToString();
            dayTwentytwoDateTextBox.Text = firstDayOfMonth.AddDays(21 - i).Day.ToString();
            dayTwentythreeDateTextBox.Text = firstDayOfMonth.AddDays(22 - i).Day.ToString();
            dayTwentyfourDateTextBox.Text = firstDayOfMonth.AddDays(23 - i).Day.ToString();
            dayTwentyfiveDateTextBox.Text = firstDayOfMonth.AddDays(24 - i).Day.ToString();
            dayTwentysixDateTextBox.Text = firstDayOfMonth.AddDays(25 - i).Day.ToString();
            dayTwentysevenDateTextBox.Text = firstDayOfMonth.AddDays(26 - i).Day.ToString();
            dayTwentyeightDateTextBox.Text = firstDayOfMonth.AddDays(27 - i).Day.ToString();

            dayTwentynineDateTextBox.Text = firstDayOfMonth.AddDays(28 - i).Day.ToString();

            if (28 - i >= DateTime.DaysInMonth(date.Year, date.Month))
            {
                dayTwentynineGrid.Background = color;
            }

            dayThirtyDateTextBox.Text = firstDayOfMonth.AddDays(29 - i).Day.ToString();

            if (29 - i >= DateTime.DaysInMonth(date.Year, date.Month))
            {
                dayThirtyGrid.Background = color;
            }

            dayThirtyoneDateTextBox.Text = firstDayOfMonth.AddDays(30 - i).Day.ToString();

            if (30 - i >= DateTime.DaysInMonth(date.Year, date.Month))
            {
                dayThirtyoneGrid.Background = color;
            }

            dayThirtytwoDateTextBox.Text = firstDayOfMonth.AddDays(31 - i).Day.ToString();

            if (31 - i >= DateTime.DaysInMonth(date.Year, date.Month))
            {
                dayThirtytwoGrid.Background = color;
            }

            dayThirtythreeDateTextBox.Text = firstDayOfMonth.AddDays(32 - i).Day.ToString();

            if (32 - i >= DateTime.DaysInMonth(date.Year, date.Month))
            {
                dayThirtytwoGrid.Background = color;
            }

            dayThirtyfourDateTextBox.Text = firstDayOfMonth.AddDays(33 - i).Day.ToString();

            if (33 - i >= DateTime.DaysInMonth(date.Year, date.Month))
            {
                dayThirtythreeGrid.Background = color;
            }

            dayThirtyfiveDateTextBox.Text = firstDayOfMonth.AddDays(34 - i).Day.ToString();

            if (34 - i >= DateTime.DaysInMonth(date.Year, date.Month))
            {
                dayThirtyfiveGrid.Background = color;
            }
        }

        private DateTime getIsoWeekOne(int _year)
        {
            DateTime dt = new DateTime(_year, 1, 4);

            int dayNumber = (int)dt.DayOfWeek;

            if (dayNumber == 0)
                dayNumber = 7;

            return dt.AddDays(1 - dayNumber);
        }

        private int getIsoWeek(DateTime _dt)
        {
            DateTime week1;
            int isoYear = _dt.Year;

            if (_dt >= new DateTime(isoYear, 12, 29))
            {
                week1 = getIsoWeekOne(isoYear + 1);

                if (_dt < week1)
                    week1 = getIsoWeekOne(isoYear);
                else
                    isoYear++;
            }
            else
            {
                week1 = getIsoWeekOne(isoYear);

                if (_dt < week1)
                    week1 = getIsoWeekOne(--isoYear);
            }

            return (isoYear * 100) + ((_dt - week1).Days / 7 + 1);
        }
    }
}
