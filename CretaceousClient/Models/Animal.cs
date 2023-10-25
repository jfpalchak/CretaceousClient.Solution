using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CretaceousClient.Models;

public class Animal 
{
  public int AnimalId { get; set; }
  public string Name { get; set; }
  public string Species { get; set; }
  public int Age { get; set; }

  public static List<Animal> GetAnimals()
  {
    var apiCallTask = ApiHelper.GetAll();
    var result = apiCallTask.Result;

    JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    List<Animal> animalList = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse.ToString());

    return animalList;
  }
}