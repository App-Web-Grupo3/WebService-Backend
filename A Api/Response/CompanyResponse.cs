﻿using Data.Model;

namespace UniqueTrip.Response;

public class CompanyResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Mail { get; set; }
    public string Description { get; set; }
    public string Ruc { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string ProfilePicture { get; set; }
    public int RepresentativeId { get; set; } 
}