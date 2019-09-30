using Microsoft.VisualBasic;
using System;
using System.Windows;
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
        Brush currentMonthColor = Brushes.White;
        Brush otherMonthColor = Brushes.Gray;
        Brush todayBorderColor = Brushes.CadetBlue;
        Brush defaultBorderColor = Brushes.Black;

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
            int firstDayOfMonthValue;

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
            firstDayOfMonthValue = loadFirstWeek();

            dayEightDateTextBox.Text = firstDayOfMonth.AddDays(7 - firstDayOfMonthValue).Day.ToString();
            dayNineDateTextBox.Text = firstDayOfMonth.AddDays(8 - firstDayOfMonthValue).Day.ToString();
            dayTenDateTextBox.Text = firstDayOfMonth.AddDays(9 - firstDayOfMonthValue).Day.ToString();
            dayElevenDateTextBox.Text = firstDayOfMonth.AddDays(10 - firstDayOfMonthValue).Day.ToString();
            dayTwelveDateTextBox.Text = firstDayOfMonth.AddDays(11 - firstDayOfMonthValue).Day.ToString();
            dayThirteenDateTextBox.Text = firstDayOfMonth.AddDays(12 - firstDayOfMonthValue).Day.ToString();
            dayFourteenDateTextBox.Text = firstDayOfMonth.AddDays(13 - firstDayOfMonthValue).Day.ToString();
            dayFifteenDateTextBox.Text = firstDayOfMonth.AddDays(14 - firstDayOfMonthValue).Day.ToString();
            daySixteenDateTextBox.Text = firstDayOfMonth.AddDays(15 - firstDayOfMonthValue).Day.ToString();
            daySeventeenDateTextBox.Text = firstDayOfMonth.AddDays(16 - firstDayOfMonthValue).Day.ToString();
            dayEighteenDateTextBox.Text = firstDayOfMonth.AddDays(17 - firstDayOfMonthValue).Day.ToString();
            dayNineteenDateTextBox.Text = firstDayOfMonth.AddDays(18 - firstDayOfMonthValue).Day.ToString();
            dayTwentyDateTextBox.Text = firstDayOfMonth.AddDays(19 - firstDayOfMonthValue).Day.ToString();
            dayTwentyoneDateTextBox.Text = firstDayOfMonth.AddDays(20 - firstDayOfMonthValue).Day.ToString();
            dayTwentytwoDateTextBox.Text = firstDayOfMonth.AddDays(21 - firstDayOfMonthValue).Day.ToString();
            dayTwentythreeDateTextBox.Text = firstDayOfMonth.AddDays(22 - firstDayOfMonthValue).Day.ToString();
            dayTwentyfourDateTextBox.Text = firstDayOfMonth.AddDays(23 - firstDayOfMonthValue).Day.ToString();
            dayTwentyfiveDateTextBox.Text = firstDayOfMonth.AddDays(24 - firstDayOfMonthValue).Day.ToString();
            dayTwentysixDateTextBox.Text = firstDayOfMonth.AddDays(25 - firstDayOfMonthValue).Day.ToString();
            dayTwentysevenDateTextBox.Text = firstDayOfMonth.AddDays(26 - firstDayOfMonthValue).Day.ToString();
            dayTwentyeightDateTextBox.Text = firstDayOfMonth.AddDays(27 - firstDayOfMonthValue).Day.ToString();

            dayTwentynineDateTextBox.Text = firstDayOfMonth.AddDays(28 - firstDayOfMonthValue).Day.ToString();

            if (28 - firstDayOfMonthValue >= DateTime.DaysInMonth(date.Year, date.Month))
                dayTwentynineGrid.Background = otherMonthColor;
            else
                dayTwentynineGrid.Background = currentMonthColor;

            dayThirtyDateTextBox.Text = firstDayOfMonth.AddDays(29 - firstDayOfMonthValue).Day.ToString();

            if (29 - firstDayOfMonthValue >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtyGrid.Background = otherMonthColor;
            else
                dayThirtyGrid.Background = currentMonthColor;

            dayThirtyoneDateTextBox.Text = firstDayOfMonth.AddDays(30 - firstDayOfMonthValue).Day.ToString();

            if (30 - firstDayOfMonthValue >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtyoneGrid.Background = otherMonthColor;
            else
                dayThirtyoneGrid.Background = currentMonthColor;

            dayThirtytwoDateTextBox.Text = firstDayOfMonth.AddDays(31 - firstDayOfMonthValue).Day.ToString();

            if (31 - firstDayOfMonthValue >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtytwoGrid.Background = otherMonthColor;
            else
                dayThirtytwoGrid.Background = currentMonthColor;

            dayThirtythreeDateTextBox.Text = firstDayOfMonth.AddDays(32 - firstDayOfMonthValue).Day.ToString();

            if (32 - firstDayOfMonthValue >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtythreeGrid.Background = otherMonthColor;
            else
                dayThirtythreeGrid.Background = currentMonthColor;

            dayThirtyfourDateTextBox.Text = firstDayOfMonth.AddDays(33 - firstDayOfMonthValue).Day.ToString();

            if (33 - firstDayOfMonthValue >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtyfourGrid.Background = otherMonthColor;
            else
                dayThirtyfourGrid.Background = currentMonthColor;

            dayThirtyfiveDateTextBox.Text = firstDayOfMonth.AddDays(34 - firstDayOfMonthValue).Day.ToString();

            if (34 - firstDayOfMonthValue >= DateTime.DaysInMonth(date.Year, date.Month))
                dayThirtyfiveGrid.Background = otherMonthColor;
            else
                dayThirtyfiveGrid.Background = currentMonthColor;

            if ((firstDayOfMonth.DayOfWeek == DayOfWeek.Sunday && DateTime.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month) >= 30) || (firstDayOfMonth.DayOfWeek == DayOfWeek.Saturday && DateTime.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month) >= 31))
            {
                dayTwentynineDateTextBox.Text += "/30";
            }

            if (firstDayOfMonth.DayOfWeek == DayOfWeek.Sunday && DateTime.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month) >= 31)
            {
                dayThirtyDateTextBox.Text += "/31";
            }

            markToday(firstDayOfMonth.Month == DateTime.Now.Month);
           
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

                    dayOneGrid.Background = currentMonthColor;
                    dayTwoGrid.Background = currentMonthColor;
                    dayThreeGrid.Background = currentMonthColor;
                    dayFourGrid.Background = currentMonthColor;
                    dayFiveGrid.Background = currentMonthColor;
                    daySixGrid.Background = currentMonthColor;

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

                    dayOneGrid.Background = otherMonthColor;
                    dayTwoGrid.Background = currentMonthColor;
                    dayThreeGrid.Background = currentMonthColor;
                    dayFourGrid.Background = currentMonthColor;
                    dayFiveGrid.Background = currentMonthColor;
                    daySixGrid.Background = currentMonthColor;
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

                    dayOneGrid.Background = otherMonthColor;
                    dayTwoGrid.Background = otherMonthColor;
                    dayThreeGrid.Background = currentMonthColor;
                    dayFourGrid.Background = currentMonthColor;
                    dayFiveGrid.Background = currentMonthColor;
                    daySixGrid.Background = currentMonthColor;
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

                    dayOneGrid.Background = otherMonthColor;
                    dayTwoGrid.Background = otherMonthColor;
                    dayThreeGrid.Background = otherMonthColor;
                    dayFourGrid.Background = currentMonthColor;
                    dayFiveGrid.Background = currentMonthColor;
                    daySixGrid.Background = currentMonthColor;
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

                    dayOneGrid.Background = otherMonthColor;
                    dayTwoGrid.Background = otherMonthColor;
                    dayThreeGrid.Background = otherMonthColor;
                    dayFourGrid.Background = otherMonthColor;
                    dayFiveGrid.Background = currentMonthColor;
                    daySixGrid.Background = currentMonthColor;
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

                    dayOneGrid.Background = otherMonthColor;
                    dayTwoGrid.Background = otherMonthColor;
                    dayThreeGrid.Background = otherMonthColor;
                    dayFourGrid.Background = otherMonthColor;
                    dayFiveGrid.Background = otherMonthColor;
                    daySixGrid.Background = currentMonthColor;
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

                    dayOneGrid.Background = otherMonthColor;
                    dayTwoGrid.Background = otherMonthColor;
                    dayThreeGrid.Background = otherMonthColor;
                    dayFourGrid.Background = otherMonthColor;
                    dayFiveGrid.Background = otherMonthColor;
                    daySixGrid.Background = otherMonthColor;
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

        private void markToday(bool _isCurrentMonth)
        {
            Brush brush;
            Thickness borderThickness;

            if (_isCurrentMonth)
            {
                brush = todayBorderColor;
                borderThickness = new Thickness(2.5);
            }
            else
            {
                brush = defaultBorderColor;
                borderThickness = new Thickness(1);
            }

            switch (DateTime.Now.Day + getFirstDayOfCurrentMonth())
            {
                case 1:
                    dayOneBorder.BorderBrush = brush;
                    dayOneBorder.BorderThickness = borderThickness;
                    break;
                case 2:
                    dayTwoBorder.BorderBrush = brush;
                    dayTwoBorder.BorderThickness = borderThickness;
                    break;
                case 3:
                    dayThreeBorder.BorderBrush = brush;
                    dayThreeBorder.BorderThickness = borderThickness;
                    break;
                case 4:
                    dayFourBorder.BorderBrush = brush;
                    dayFourBorder.BorderThickness = borderThickness;
                    break;
                case 5:
                    dayFiveBorder.BorderBrush = brush;
                    dayFiveBorder.BorderThickness = borderThickness;
                    break;
                case 6:
                    daySixBorder.BorderBrush = brush;
                    daySixBorder.BorderThickness = borderThickness;
                    break;
                case 7:
                    daySevenBorder.BorderBrush = brush;
                    daySevenBorder.BorderThickness = borderThickness;
                    break;
                case 8:
                    dayEightBorder.BorderBrush = brush;
                    dayEightBorder.BorderThickness = borderThickness;
                    break;
                case 9:
                    dayNineBorder.BorderBrush = brush;
                    dayNineBorder.BorderThickness = borderThickness;
                    break;
                case 10:
                    dayTenBorder.BorderBrush = brush;
                    dayTenBorder.BorderThickness = borderThickness;
                    break;
                case 11:
                    dayElevenBorder.BorderBrush = brush;
                    dayElevenBorder.BorderThickness = borderThickness;
                    break;
                case 12:
                    dayTwelveBorder.BorderBrush = brush;
                    dayTwelveBorder.BorderThickness = borderThickness;
                    break;
                case 13:
                    dayThirteenBorder.BorderBrush = brush;
                    dayThirteenBorder.BorderThickness = borderThickness;
                    break;
                case 14:
                    dayFourteenBorder.BorderBrush = brush;
                    dayFourteenBorder.BorderThickness = borderThickness;
                    break;
                case 15:
                    dayFifteenBorder.BorderBrush = brush;
                    dayFifteenBorder.BorderThickness = borderThickness;
                    break;
                case 16:
                    daySixteenBorder.BorderBrush = brush;
                    daySixteenBorder.BorderThickness = borderThickness;
                    break;
                case 17:
                    daySeventeenBorder.BorderBrush = brush;
                    daySeventeenBorder.BorderThickness = borderThickness;
                    break;
                case 18:
                    dayEighteenBorder.BorderBrush = brush;
                    dayEighteenBorder.BorderThickness = borderThickness;
                    break;
                case 19:
                    dayNineteenBorder.BorderBrush = brush;
                    dayNineteenBorder.BorderThickness = borderThickness;
                    break;
                case 20:
                    dayTwentyBorder.BorderBrush = brush;
                    dayTwentyBorder.BorderThickness = borderThickness;
                    break;
                case 21:
                    dayTwentyoneBorder.BorderBrush = brush;
                    dayTwentyoneBorder.BorderThickness = borderThickness;
                    break;
                case 22:
                    dayTwentytwoBorder.BorderBrush = brush;
                    dayTwentytwoBorder.BorderThickness = borderThickness;
                    break;
                case 23:
                    dayTwentythreeBorder.BorderBrush = brush;
                    dayTwentythreeBorder.BorderThickness = borderThickness;
                    break;
                case 24:
                    dayTwentyfourBorder.BorderBrush = brush;
                    dayTwentyfourBorder.BorderThickness = borderThickness;
                    break;
                case 25:
                    dayTwentyfiveBorder.BorderBrush = brush;
                    dayTwentyfiveBorder.BorderThickness = borderThickness;
                    break;
                case 26:
                    dayTwentysixBorder.BorderBrush = brush;
                    dayTwentysixBorder.BorderThickness = borderThickness;
                    break;
                case 27:
                    dayTwentysevenBorder.BorderBrush = brush;
                    dayTwentysevenBorder.BorderThickness = borderThickness;
                    break;
                case 28:
                    dayTwentyeightBorder.BorderBrush = brush;
                    dayTwentyeightBorder.BorderThickness = borderThickness;
                    break;
                case 29:
                    dayTwentynineBorder.BorderBrush = brush;
                    dayTwentynineBorder.BorderThickness = borderThickness;
                    break;
                case 30:
                    dayThirtyBorder.BorderBrush = brush;
                    dayThirtyBorder.BorderThickness = borderThickness;
                    break;
                case 31:
                    dayThirtyoneBorder.BorderBrush = brush;
                    dayThirtyoneBorder.BorderThickness = borderThickness;
                    break;
                case 32:
                    dayThirtytwoBorder.BorderBrush = brush;
                    dayThirtytwoBorder.BorderThickness = borderThickness;
                    break;
                case 33:
                    dayThirtythreeBorder.BorderBrush = brush;
                    dayThirtythreeBorder.BorderThickness = borderThickness;
                    break;
                case 34:
                    dayThirtyfourBorder.BorderBrush = brush;
                    dayThirtyfourBorder.BorderThickness = borderThickness;
                    break;
                case 35:
                    dayThirtyfiveBorder.BorderBrush = brush;
                    dayThirtyfiveBorder.BorderThickness = borderThickness;
                    break;
                case 36:
                    dayTwentynineBorder.BorderBrush = brush;
                    dayTwentynineBorder.BorderThickness = borderThickness;
                    break;
                case 37:
                    dayThirtyBorder.BorderBrush = brush;
                    dayThirtyBorder.BorderThickness = borderThickness;
                    break;
                default:
                    break;
            }
        }

        private int getFirstDayOfCurrentMonth()
        {
            switch (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return 0;
                case DayOfWeek.Tuesday:
                    return 1;
                case DayOfWeek.Wednesday:
                    return 2;
                case DayOfWeek.Thursday:
                    return 3;
                case DayOfWeek.Friday:
                    return 4;
                case DayOfWeek.Saturday:
                    return 5;
                case DayOfWeek.Sunday:
                    return 6;
                default:
                    return -1;
            }
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

        public string showToday()
        {
            date = DateTime.Now;
            loadCurrentMonth();

            return DateAndTime.MonthName(date.Month) + " " + date.Year;
        }

        public string changeDate(DateTime _date)
        {
            date = _date;

            loadCurrentMonth();

            return DateAndTime.MonthName(date.Month) + " " + date.Year;
        }
    }
}
