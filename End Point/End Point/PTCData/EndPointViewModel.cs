using System;
using System.Collections.Generic;
using EndPointCommon;

namespace EndPointData
{
  public class EndPointViewModel : ViewModelBase
  {
    public EndPointViewModel()
      : base()
    {
      // Initialize other variables
      Products = new List<EndPoint>();
      SearchEntity = new EndPoint();
      Entity = new EndPoint();
    }

    public List<EndPoint> Products { get; set; }
    public EndPoint SearchEntity { get; set; }
    public EndPoint Entity { get; set; }

    protected override void Init()
    {
      Products = new List<EndPoint>();
      SearchEntity = new EndPoint();
      Entity = new EndPoint();

      base.Init();
    }

    public override void HandleRequest()
    {
      // This is an example of adding on a new command
      switch (EventCommand.ToLower())
      {
        case "newcommand":
          break;

      }

      base.HandleRequest();
    }

    protected override void Add()
    {
      IsValid = true;

      // Initialize Entity Object
      Entity = new EndPoint();
      Entity.EndPointName = "";
      Entity.Environment = "";
      Entity.ServiceName = "";

      base.Add();
    }

    protected override void Edit()
    {
      EndPointManager mgr =
       new EndPointManager();

      // Get Product Data
      Entity = mgr.Get(
        Convert.ToInt32(EventArgument));

      base.Edit();
    }

    protected override void Save()
    {
      EndPointManager mgr =
        new EndPointManager();

      if (Mode == "Add")
      {
        mgr.Insert(Entity);
      }
      else
      {
        mgr.Update(Entity);
      }

      // Set any validation errors
      ValidationErrors = mgr.ValidationErrors;

      // Set mode based on validation errors
      base.Save();
    }

    protected override void Delete()
    {
      EndPointManager mgr =
        new EndPointManager();

      // Create new entity
      Entity = new EndPoint();

      // Get primary key from EventArgument
      Entity.EndPointId =
        Convert.ToInt32(EventArgument);

      // Call data layer to delete record
      mgr.Delete(Entity);

      // Reload the Data
      Get();

      base.Delete();
    }

    protected override void ResetSearch()
    {
      SearchEntity = new EndPoint();

      base.ResetSearch();
    }

    protected override void Get()
    {
      EndPointManager mgr = new EndPointManager();

      Products = mgr.Get(SearchEntity);

      base.Get();
    }
  }
}
