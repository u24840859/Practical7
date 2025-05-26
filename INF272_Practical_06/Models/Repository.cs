﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Practical_06.Models
{
    public class Repository
    {
        public List<Publication> GetPublications()
        {
            return new List<Publication>()
            {
                new Article
                {
                    Author = new Author { Name = "Koffi Umukoro" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2018/03/02/20/22/sktop-3194194__340.jpg",
                    MainStoryURL = "https://bait.example.net/bag.aspx",
                    Summary = "Addison is a detective from Sale who falls in love with his best friend. The two are separated when the best friend falls for somebody else. However, Addison manages to rescue the situation by buying a magnificent t-shirt.",
                    Title = "Improving the foundation of our falling sand simulator",
                    PublicationDate = new DateTime(2018, 7, 24),
                    Type = "Article",
                },
                new Book
                {
                    Author = new Author { Name = "Octavia Barret" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2016/08/18/08/31/lemur-1602313__340.jpg",
                    MainStoryURL = "https://www.example.com/bite.aspx",
                    Summary = "A farmer from Markham is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered when her son goes missing. Unexpectedly, the farmer is bitten by a zombie and therefore is disqualified from competing.",
                    Title = "NASA fed some Apollo 11 lunar samples to cockroaches and mice",
                    PublicationDate = new DateTime(2006, 5, 15),
                    Type = "Book",
                    Editions = "2",
                },
                new Article
                {
                    Author = new Author { Name = "Gunnhild Aric" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2017/06/14/11/34/meadow-2401931__340.jpg",
                    MainStoryURL = "https://example.com/bone/basin.php?bed=bedroom&boat=amusement#boundary",
                    Summary = "A caretaker from Lehi is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered by an angyy camel. After the drama, the caretaker realises there is more to life than winning X-Factor and goes on a picninc with her great aunt instead.",
                    Title = "When Your Smart ID Card Reader Comes with Malware",
                    PublicationDate = new DateTime(2023, 3, 21),
                    Type = "Article"
                },
                new Book
                {
                    Author = new Author { Name = "Jakob Ayanda" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2016/08/20/05/44/clock-1606919__340.jpg",
                    MainStoryURL = "https://www.example.com/baseball/basin.php?attraction=anger&bead=amusement",
                    Summary = "In a world where robots are wealthy, one golfer has no choice but to assasinate an honorable man by killing his own ex-wife. Eventually, the golfer forms an army and teaches the robots a little respect.",
                    Title = "Jailer: A truly relational database tool",
                    PublicationDate = new DateTime(1989, 6, 6),
                    Type = "Book",
                    Editions = "3",
                },
                new Article
                {
                    Author = new Author { Name = "Shyam Benson" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2016/09/01/10/33/witchs-house-1635770_960_720.jpg",
                    MainStoryURL = "https://www.example.com/bait/bath.php",
                    Summary = "In a world where robots are miraculously transformed into angels, one pop star has no choice but to bring down the goverment by killing her own step-sister. It turns out all the robots were a manifestations of the pop star's multiple personality disorder and her real fight is one to regain sanity.",
                    Title = "sEverything you ever wanted to know about terminal",
                    PublicationDate = new DateTime(2020, 1, 23),
                    Type = "Article"
                },
                new Article
                {
                    Author = new Author { Name = "Lucas Asim" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2016/04/25/07/15/man-1351317__340.png",
                    MainStoryURL = "http://www.example.com/bear",
                    Summary = "When a movie star from West Des Moines learns to sing, not everybody is supportive. However, her fortunes improve when her step-sister buys a deralict castle. Eventually, the movie star realises that she has always been a worthwhile person and does not need to change.",
                    Title = "NaturalSpeech: End-to-end text to speech synthesis with human-level quality",
                    PublicationDate = new DateTime(2022, 10, 28),
                    Type = "Article"
                },
                new Article
                {
                    Author = new Author { Name = "Harmon Deeann" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2020/03/13/08/19/ornaments-4927258__340.jpg",
                    MainStoryURL = "https://www.example.com/bells",
                    Summary = "A WW2 veteran Brisbane who recieves an invitation to a modern battle. It turns out the invitations is spam and is from a scammer who is famous for making up stories.",
                    Title = "Husky, Datadog's Third-Generation Event Store",
                    PublicationDate = new DateTime(2022, 3, 4),
                    Type = "Article",
                },
                new Book
                {
                    Author = new Author { Name = "Gargi Sudheer" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2016/08/07/18/22/back-to-school-1576791__340.jpg",
                    MainStoryURL = "https://example.com/baseball/adjustment.aspx?airplane=border&advertisement=argument",
                    Summary = "In a world where vampires run large corporations, one singer has no choice but to protect mankind using a magic ring. It turns out the vampires are all sheep.",
                    Title = "Singers and Vampires",
                    PublicationDate = new DateTime(1972, 4, 24),
                    Type = "Book",
                    Editions = "3",
                }
            };
        }
    }
}