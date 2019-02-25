using System;

namespace Sandbox
{
    public class Review
    {
        private decimal rating;
        public int Id { get; set; }
        public decimal Rating
        {
            get => rating;
            set => rating = decimal.Round(value ,1);
        }

        public int ItemId { get; set; }
        public string ReviewText { get; set; }
        public string Reviewer { get; set; }
    }
}