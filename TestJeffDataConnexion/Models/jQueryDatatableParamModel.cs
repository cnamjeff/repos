using System;
using System.Collections.Generic;


namespace TestJeffDataConnexion.Models
{
    public class jQueryDataTableParamModel
    {
        /// <summary>
        /// Draw counter. This is used by DataTables to ensure that the Ajax returns from server-side processing requests are drawn in sequence by DataTables 
        /// (Ajax requests are asynchronous and thus can return out of sequence). 
        /// This is used as part of the draw return parameter 
        /// </summary>       
        public int draw { get; set; }

        /// <summary>
        /// Paging first record indicator. This is the start point in the current data set (0 index based - i.e. 0 is the first record).
        /// </summary>
        public int start { get; set; }

        /// <summary>
        /// Number of records that the table can display in the current draw. 
        /// It is expected that the number of records returned will be equal to this number, 
        /// unless the server has fewer records to return. Note that this can be -1 to indicate that all records should be returned 
        /// (although that negates any benefits of server-side processing!)
        /// </summary>
        public int length { get; set; }

        /// <summary>
        /// searchMinDate
        /// </summary>
        public DataTableSearchModel search { get; set; }

        /// <summary>
        /// order
        /// </summary>
        public List<DataTableOrder> order { get; set; }


        /// <summary>
        /// colonnes
        /// </summary>
        public List<DataTableColumns> columns { get; set; }



        /// <summary>
        /// extra parameter
        /// </summary>
        public DateTime? MinDate { get; set; }
        /// <summary>
        /// extra parameter
        /// </summary>
        public DateTime? MaxDate { get; set; }

        public string Etat { get; set; }

    }

    public class DataTableSearchModel
    {
        /// <summary>
        /// Global search value. To be applied to all columns which have searchable as true.
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// true if the global filter should be treated as a regular expression for advanced searching, false otherwise. Note that normally server-side processing scripts will not perform regular expression searching for performance reasons on large data sets, but it is technically possible and at the discretion of your script.
        /// </summary>
        public bool regex { get; set; }

        public string overValue { get; set; }

        public bool? isActive { get; set; }
    }


    public class DataTableColumns
    {
        public string data { get; set; }

        public string name { get; set; }

        public bool searchable { get; set; }

        public bool orderable { get; set; }

        /// <summary>
        /// search
        /// </summary>
        public DataTableSearchModel search { get; set; }
    }


    public class DataTableOrder
    {
        public int column { get; set; }

        public string dir { get; set; }

    }
}