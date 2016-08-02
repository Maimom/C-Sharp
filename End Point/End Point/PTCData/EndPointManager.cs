using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndPointData
{
  public class EndPointManager
  {
    public EndPointManager()
    {
      ValidationErrors = new List<KeyValuePair<string, string>>();
    }

    public List<KeyValuePair<string, string>> ValidationErrors { get; set; }

    public List<EndPoint> Get()
    {
      return Get(new EndPoint());
    }

    public List<EndPoint> Get(EndPoint entity)
    {
      List<EndPoint> ret = new List<EndPoint>();

      // TODO: Add your own data access method here
      ret = CreateMockData();

      // Do any searching
      if (!string.IsNullOrEmpty(entity.EndPointName))
      {
        ret = ret.FindAll(
          p => p.EndPointName.ToLower().
                StartsWith(entity.EndPointName,
                          StringComparison.CurrentCultureIgnoreCase));
      }

      return ret;
    }

    public EndPoint Get(int productId)
    {
      List<EndPoint> ret =
        new List<EndPoint>();
      EndPoint entity = null;

      // TODO: Add data access method here
      ret = CreateMockData();

      // Find the specific product
      entity = ret.Find(p =>
         p.EndPointId == productId);

      return entity;
    }

    public bool Update(EndPoint entity)
    {
      bool ret = false;

      ret = Validate(entity);

      if (ret)
      {
        /// TODO: Create UPDATE code here
      }

      return ret;
    }

    public bool Delete(EndPoint entity)
    {
      /// TODO: Create DELETE code here
      return true;
    }

    public bool Validate(EndPoint entity)
    {
      ValidationErrors.Clear();

      if (!string.IsNullOrEmpty(entity.EndPointName))
      {
        if (entity.EndPointName.ToLower() ==
            entity.EndPointName)
        {
          ValidationErrors.Add(new
            KeyValuePair<string, string>("EndPointName",
            "Product must not be all lower case."));
        }
      }

      return (ValidationErrors.Count == 0);
    }

    public bool Insert(EndPoint entity)
    {
      bool ret = false;

      ret = Validate(entity);

      if (ret)
      {
        /// TODO: Create INSERT code here
      }

      return ret;
    }

    protected List<EndPoint> CreateMockData()
    {
      List<EndPoint> ret = new List<EndPoint>();

      ret.Add(new EndPoint()
      {
        EndPointId = 1,
        EndPointName = "Extending Bootstrap with CSS, JavaScript and jQuery",
        Environment ="Dev",
        ServiceName="test web"

      });

      
      return ret;
    }
  }
}
