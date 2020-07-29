using System;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Models
{
    public class Students
    {
public int id {get; set;}
[Required]
public string first_name {get; set;}
[Required]
public string last_name {get; set;}
    }
}