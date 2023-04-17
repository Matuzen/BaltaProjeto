using System;

namespace ProjetoBalta.ContentContext
{
    public class Content
    {
        public Content()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public int Title { get; set; }
        public string Url { get; set; }

    }
}