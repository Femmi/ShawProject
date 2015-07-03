using System;
using System.Collections.Generic;

namespace DataLayer.Model
{
     public class ResultModelSortByName: IComparer<ResultModel>
     {
         #region IComparer<ResultModel> Members

         public int Compare(ResultModel obj, ResultModel otherObj)
         {
             return String.CompareOrdinal(obj.Name, otherObj.Name);
         }

         #endregion
    }
}
