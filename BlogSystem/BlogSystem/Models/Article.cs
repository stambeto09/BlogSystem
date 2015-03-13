namespace BlogSystem
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Article
    {
        public Article()
        {

        }

        public Article(int articleID, string content, string articleName,
            DateTime datePublished, string author)
        {
            this.ArticleID = articleID;
            this.Content = content;
            this.ArticleName = articleName;
            this.DatePublished = datePublished;
            this.Author = author;
        }

        [Required]
        public int ArticleID { get; set; }

        [Required]
        [DataType(DataType.Html)]
        public string Content { get; set; }

        [Required]
        [Display(Name="Article Header")]
        public string ArticleName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name="Date Published")]
        public DateTime DatePublished { get; set; }

        [Required]
        public string Author { get; set; }

    }
}
