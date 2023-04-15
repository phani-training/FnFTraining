using System;
using System.Collections.Generic;

namespace SampleMvcApp.Models;

public partial class TblBook
{
    public int BookId { get; set; }

    public string BookTitle { get; set; } = null!;

    public string Author { get; set; } = null!;

    public int BookPrice { get; set; }

    public string BookPublisher { get; set; } = null!;
}
