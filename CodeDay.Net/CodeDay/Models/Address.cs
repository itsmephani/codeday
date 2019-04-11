using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDay.Models
{
  class Address
  {
    public string FlatNo { get; set; }
    public string Lane { get; set; }
    public string Landmark { get; set; }

    public class Builder
    {
      Address address;
      private string flatNo { get; set; }
      private string lane { get; set; }
      private string landmark { get; set; }

      public Builder SetFlatNo(string flatNo)
      {
        this.flatNo = flatNo;

        return this;
      }

      public Builder SetLane(string lane)
      {
        this.lane = lane;

        return this;
      }

      public Builder SetLandmark(string flatNo)
      {
        this.landmark = landmark;

        return this;
      }

      public string GetFlatNo()
      {
        return flatNo;
      }
      public string GetLane()
      {
        return lane;
      }
      public string GetLandmark()
      {
        return landmark;
      }

      public Address Build()
      {
        return new Address
        {
          FlatNo = flatNo,
          Lane = lane,
          Landmark = landmark
        };
      }
    }
  }
}
