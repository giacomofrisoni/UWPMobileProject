﻿using System;

namespace MyPoetry.Model
{
    class Poetry
    {
        public string UserEmail { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime RevisionDate { get; set; }
        public int CharactersNumber { get; set; }
        public int WordsNumber { get; set; }
        public int VersesNumber { get; set; }
        public bool BookmarkYN { get; set; }
    }
}
