﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SalonComplex.Model
{
    public class FullCalendar
    {
        private bool _allday = false;
        private bool _editable = false;
       
        public int id { get; set; }
        public string title { get; set; }

        [JsonProperty(ItemConverterType = typeof(IsoDateTimeConverter))]
        public DateTime start { get; set; }

        [JsonProperty(ItemConverterType = typeof(IsoDateTimeConverter))]
        public DateTime end { get; set; }
        public bool allDay
        {
            set { _allday = value; }
            get { return _allday; }
        }
        public bool editable
        {
            set { _editable = value; }
            get { return _editable; }
        }
    }
}