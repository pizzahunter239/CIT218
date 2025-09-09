using System.ComponentModel.DataAnnotations;

namespace DetectiveAgency.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please enter the employee's first name.")]
        [StringLength(30, ErrorMessage = "First name must be 30 characters or less.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the employee's last name.")]
        [StringLength(30, ErrorMessage = "Last name must be 30 characters or less.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter the hourly rate.")]
        [Range(15.00, 50.00, ErrorMessage = "Hourly rate must be between $15.00 and $50.00.")]
        public decimal? HourlyRate { get; set; }

        [Required(ErrorMessage = "Please enter the hours worked.")]
        [Range(1, 168, ErrorMessage = "Hours worked must be between 1 and 168.")]
        public decimal? HoursWorked { get; set; }

        public decimal Salary { get; set; } = 0;

        public decimal CalculateWeeklySalary()
        {
            if (HourlyRate.HasValue && HoursWorked.HasValue)
            {
                if (HoursWorked <= 40)
                {
                    return HourlyRate.Value * HoursWorked.Value;
                }
                else
                {
                    decimal regularPay = HourlyRate.Value * 40;
                    decimal overtimePay = HourlyRate.Value * 1.5m * (HoursWorked.Value - 40);
                    return regularPay + overtimePay;
                }
            }
            return 0;
        }
    }
}