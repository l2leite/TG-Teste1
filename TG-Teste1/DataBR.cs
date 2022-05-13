using System;

namespace DataBR;

public class DataBR
{
	DateTime data = new DateTime();

	public DateTime Data
	{
        get
        {
            return data.Date;
        }
        set 
        {
            data = value;
        }

    }

    public override string ToString()
    {
        string novadata;
        novadata = $"{data.Day, 00:00}/{data.Month, 00:00}/{data.Year}";
        return novadata;
    }
    



}
