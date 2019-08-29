using Microsoft.VisualBasic;
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
        public DateTime date;
        DateTime previousMonth;
        DateTime firstDayOfMonth;
        Brush defaultColor = Brushes.White;
        Brush color = Brushes.Gray;

        public MonthView(DateTime _now)
        {
            InitializeComponent();
            init(_now);
        }

        private void init(DateTime _now)
        {
            date = _now;

            loadCurrentMonth();
        }

        public void loadCurrentMonth()
        {
            int i;

            if (date.Month == 1)
            {
                previousMonth = new DateTime(date.Year - 1, 12, DateTime.DaysInMonth(date.Year - 1, 12));
            }
            else
            {
                previousMonth = new DateTime(date.Year, date.Month - 1, DateTime.DaysInMonth(date.Year, date.Month - 1));
            }

            firstDayOfMonth = new DateTime(date.Year, date.Month, 1);

            loadCW();
            i = loadFirstWeek();

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
                dayTwentynineGrid.Background = color;
            else
                dayTwentynineGrid.Background = defaultColor;

            dayThirtyDateTextBox.Text = firstDayOfMonth.AddDays(29 - i).Day.ToString();

            if (29 - i >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtyGrid.Background = color;
            else
                dayThirtyGrid.Background = defaultColor;

            dayThirtyoneDateTextBox.Text = firstDayOfMonth.AddDays(30 - i).Day.ToString();

            if (30 - i >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtyoneGrid.Background = color;
            else
                dayThirtyoneGrid.Background = defaultColor;

            dayThirtytwoDateTextBox.Text = firstDayOfMonth.AddDays(31 - i).Day.ToString();

            if (31 - i >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtytwoGrid.Background = color;
            else
                dayThirtytwoGrid.Background = defaultColor;

            dayThirtythreeDateTextBox.Text = firstDayOfMonth.AddDays(32 - i).Day.ToString();

            if (32 - i >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtythreeGrid.Background = color;
            else
                dayThirtythreeGrid.Background = defaultColor;

            dayThirtyfourDateTextBox.Text = firstDayOfMonth.AddDays(33 - i).Day.ToString();

            if (33 - i >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtyfourGrid.Background = color;
            else
                dayThirtyfourGrid.Background = defaultColor;

            dayThirtyfiveDateTextBox.Text = firstDayOfMonth.AddDays(34 - i).Day.ToString();

            if (34 - i >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtyfiveGrid.Background = color;
            else
                dayThirtyfiveGrid.Background = defaultColor;

            if ((firstDayOfMonth.DayOfWeek == DayOfWeek.Sunday && DateTime.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month) >= 30) || (firstDayOfMonth.DayOfWeek == DayOfWeek.Saturday && DateTime.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month) >= 31))
            {
                dayTwentynineDateTextBox.Text += "/30";
            }

            if (firstDayOfMonth.DayOfWeek == DayOfWeek.Sunday && DateTime.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month) >= 31)
            {
                dayThirtyDateTextBox.Text += "/31";
            }
        }

        private void loadCW()
        {
            int CW = getIsoWeek(date) % 100;

            weekOneTextBox.Text = "CW " + CW.ToString();
            weekTwoTextBox.Text = "CW " + (CW + 1).ToString();
            weekThreeTextBox.Text = "CW " + (CW + 2).ToString();
            weekFourTextBox.Text = "CW " + (CW + 3).ToString();
            weekFiveTextBox.Text = "CW " + (CW + 4).ToString();
        }

        private int loadFirstWeek()
        {
            int ret = 0;

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

                    dayOneGrid.Background = defaultColor;
                    dayTwoGrid.Background = defaultColor;
                    dayThreeGrid.Background = defaultColor;
                    dayFourGrid.Background = defaultColor;
                    dayFiveGrid.Background = defaultColor;
                    daySixGrid.Background = defaultColor;
                    break;
                case DayOfWeek.Tuesday:
                    ret = 1;

                    dayOneDateTextBox.Text = previousMonth.Day.ToString();
                    dayTwoDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    dayThreeDateTextBox.Text = firstDayOfMonth.AddDays(1).Day.ToString();
                    dayFourDateTextBox.Text = firstDayOfMonth.AddDays(2).Day.ToString();
                    dayFiveDateTextBox.Text = firstDayOfMonth.AddDays(3).Day.ToString();
                    daySixDateTextBox.Text = firstDayOfMonth.AddDays(4).Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.AddDays(5).Day.ToString();

                    dayOneGrid.Background = color;
                    dayTwoGrid.Background = defaultColor;
                    dayThreeGrid.Background = defaultColor;
                    dayFourGrid.Background = defaultColor;
                    dayFiveGrid.Background = defaultColor;
                    daySixGrid.Background = defaultColor;
                    break;
                case DayOfWeek.Wednesday:
                    ret = 2;

                    dayOneDateTextBox.Text = (previousMonth.Day - 1).ToString();
                    dayTwoDateTextBox.Text = previousMonth.Day.ToString();
                    dayThreeDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    dayFourDateTextBox.Text = firstDayOfMonth.AddDays(1).Day.ToString();
                    dayFiveDateTextBox.Text = firstDayOfMonth.AddDays(2).Day.ToString();
                    daySixDateTextBox.Text = firstDayOfMonth.AddDays(3).Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.AddDays(4).Day.ToString();

                    dayOneGrid.Background = color;
                    dayTwoGrid.Background = color;
                    dayThreeGrid.Background = defaultColor;
                    dayFourGrid.Background = defaultColor;
                    dayFiveGrid.Background = defaultColor;
                    daySixGrid.Background = defaultColor;
                    break;
                case DayOfWeek.Thursday:
                    ret = 3;

                    dayOneDateTextBox.Text = (previousMonth.Day - 2).ToString();
                    dayTwoDateTextBox.Text = (previousMonth.Day - 1).ToString();
                    dayThreeDateTextBox.Text = previousMonth.Day.ToString();
                    dayFourDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    dayFiveDateTextBox.Text = firstDayOfMonth.AddDays(1).Day.ToString();
                    daySixDateTextBox.Text = firstDayOfMonth.AddDays(2).Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.AddDays(3).Day.ToString();

                    dayOneGrid.Background = color;
                    dayTwoGrid.Background = color;
                    dayThreeGrid.Background = color;
                    dayFourGrid.Background = defaultColor;
                    dayFiveGrid.Background = defaultColor;
                    daySixGrid.Background = defaultColor;
                    break;
                case DayOfWeek.Friday:
                    ret = 4;

                    dayOneDateTextBox.Text = (previousMonth.Day - 3).ToString();
                    dayTwoDateTextBox.Text = (previousMonth.Day - 2).ToString();
                    dayThreeDateTextBox.Text = (previousMonth.Day - 1).ToString();
                    dayFourDateTextBox.Text = previousMonth.Day.ToString();
                    dayFiveDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    daySixDateTextBox.Text = firstDayOfMonth.AddDays(1).Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.AddDays(2).Day.ToString();

                    dayOneGrid.Background = color;
                    dayTwoGrid.Background = color;
                    dayThreeGrid.Background = color;
                    dayFourGrid.Background = color;
                    dayFiveGrid.Background = defaultColor;
                    daySixGrid.Background = defaultColor;
                    break;
                case DayOfWeek.Saturday:
                    ret = 5;

                    dayOneDateTextBox.Text = (previousMonth.Day - 4).ToString();
                    dayTwoDateTextBox.Text = (previousMonth.Day - 3).ToString();
                    dayThreeDateTextBox.Text = (previousMonth.Day - 2).ToString();
                    dayFourDateTextBox.Text = (previousMonth.Day - 1).ToString();
                    dayFiveDateTextBox.Text = previousMonth.Day.ToString();
                    daySixDateTextBox.Text = firstDayOfMonth.Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.AddDays(1).Day.ToString();

                    dayOneGrid.Background = color;
                    dayTwoGrid.Background = color;
                    dayThreeGrid.Background = color;
                    dayFourGrid.Background = color;
                    dayFiveGrid.Background = color;
                    daySixGrid.Background = defaultColor;
                    break;
                case DayOfWeek.Sunday:
                    ret = 6;

                    dayOneDateTextBox.Text = (previousMonth.Day - 5).ToString();
                    dayTwoDateTextBox.Text = (previousMonth.Day - 4).ToString();
                    dayThreeDateTextBox.Text = (previousMonth.Day - 3).ToString();
                    dayFourDateTextBox.Text = (previousMonth.Day - 2).ToString();
                    dayFiveDateTextBox.Text = (previousMonth.Day - 1).ToString();
                    daySixDateTextBox.Text = previousMonth.Day.ToString();
                    daySevenDateTextBox.Text = firstDayOfMonth.Day.ToString();

                    dayOneGrid.Background = color;
                    dayTwoGrid.Background = color;
                    dayThreeGrid.Background = color;
                    dayFourGrid.Background = color;
                    dayFiveGrid.Background = color;
                    daySixGrid.Background = color;
                    break;
                default:
                    break;
            }

            return ret;
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

        public string showPreviousMonth()
        {
            int year = date.Year;
            int month = date.Month;

            if (date.Month == 1)
            {
                year--;
                month = 12;
            }
            else
            {
                month--;
            }

            date = new DateTime(year, month, 1);

            loadCurrentMonth();

            return DateAndTime.MonthName(date.Month) + " " + date.Year;
        }

        public string showNextMonth()
        {
            int year = date.Year;
            int month = date.Month;

            if (date.Month == 12)
            {
                year++;
                month = 1;
            }
            else
            {
                month++;
            }

            date = new DateTime(year, month, 1);

            loadCurrentMonth();

            return DateAndTime.MonthName(date.Month) + " " + date.Year;
        }
    }
}
