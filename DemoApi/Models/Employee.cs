using System.ComponentModel.DataAnnotations;

namespace DemoApi.Models
{
    public class Employee
    {
        public int order_item_id { get; set; }
        public string AtBedTime { get; set; }
        public string MB { get; set; }
        public string MA { get; set; }
        public string AB { get; set; }
        public string AA { get; set; }
        public string EB { get; set; }
        public string EA { get; set; }
        public int age { get; set; }
        public string patient_name { get; set; }
        public string gender { get; set; }
        public string birthofdate { get; set; }
        public string ward { get; set; }
        public string hn { get; set; }
        public string Password { get; set; }
        public string item_name { get; set; }
        public string th_name { get; set; }
        public string Diagnosis { get; set; }
        public string Allergy { get; set; }
        public string instruction_text_line1 { get; set; }
        public string instruction_text_line2 { get; set; }
        public string instruction_text_line3 { get; set; }
        public string item_description { get; set; }
        public string item_caution { get; set; }
    }
}

