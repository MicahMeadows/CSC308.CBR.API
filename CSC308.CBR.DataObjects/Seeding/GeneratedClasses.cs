namespace CSC308.CBR.DataObjects.Seeding;

// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
public class Category
{
    public int id { get; set; }
    public string name { get; set; }
    public Thumbnail thumbnail { get; set; }
    public string primaryColor { get; set; }
    public string secondaryColor { get; set; }
    public bool @checked { get; set; }
    public Icon icon { get; set; }
    public int iconType { get; set; }
    public List<Pin> pins { get; set; }
}

public class CcFile
{
    public int id { get; set; }
    public string lang { get; set; }
    public string lang_code { get; set; }
    public File file { get; set; }
}

public class File
{
    public string path { get; set; }
    public int id { get; set; }
}

public class Icon
{
    public string name { get; set; }
    public string alt_text { get; set; }
    public object width { get; set; }
    public object height { get; set; }
    public object status { get; set; }
    public bool is_placeholder { get; set; }
    public string path { get; set; }
    public object id { get; set; }
}

public class Image
{
    public string name { get; set; }
    public string alt_text { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int? status { get; set; }
    public bool is_placeholder { get; set; }
    public string path { get; set; }
    public int id { get; set; }
}

public class Panorama
{
    public string name { get; set; }
    public string alt_text { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public object status { get; set; }
    public bool is_placeholder { get; set; }
    public string path { get; set; }
    public int id { get; set; }
}

public class Pin
{
    public string name { get; set; }
    public int id { get; set; }
    public string description { get; set; }
    public double posX { get; set; }
    public double posY { get; set; }
    public int clickMode { get; set; }
    public object clickLink { get; set; }
    public List<Image> images { get; set; }
    public List<Panorama> panoramas { get; set; }
    public List<Video> videos { get; set; }
    public object url3d { get; set; }
}

public class Root
{
    public int id { get; set; }
    public string name { get; set; }
    public List<Image> images { get; set; }
    public List<Category> categories { get; set; }
}

public class Thumbnail
{
    public string name { get; set; }
    public string alt_text { get; set; }
    public object width { get; set; }
    public object height { get; set; }
    public object status { get; set; }
    public bool is_placeholder { get; set; }
    public string path { get; set; }
    public object id { get; set; }
}

public class Transcript
{
    public int id { get; set; }
    public string lang { get; set; }
    public string lang_code { get; set; }
    public string transcript { get; set; }
}

public class Video
{
    public string url { get; set; }
    public List<CcFile> cc_files { get; set; }
    public List<Transcript> transcripts { get; set; }
    public bool is_video_vr { get; set; }
    public int playlist_preview_start_time { get; set; }
}

