using System;

namespace OneListClient
{
    public class Item
    {
        public int id { get; set; }
        public string text { get; set; }
        public bool complete { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public string CompleteStatus
        {
            get
            {
                if (complete == true)
                {
                    return "Complete";
                }
                else
                {
                    return "Not Complete";
                }
            }
        }
    }
}