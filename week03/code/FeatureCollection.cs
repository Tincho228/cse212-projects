

public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary

    public string type {get; set;}
    public Meta[] metadatas {get; set;}
    public Feature[] features { get; set; }
    public double[] bbox {get; set;}
    
}
public class Meta {
    public double generated { get; set; }
    public string url { get; set; }
    public string title { get; set; }
    public int status { get; set; }
    public string api { get; set; }
    public int count { get; set; }
}
public class Feature {
    public string type { get; set; }
    public Property properties {get; set;} 
    public Geometry geometry { get; set; } 
    public string Id { get; set; }
    
}
public class Property {
    public double mag {get; set;} 
    public string place {get; set;}
    
}
public class Geometry {
    public string type {get; set;}
    public double[] coordinates {get; set;}
}