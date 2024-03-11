//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkingManagement.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class VehicleParking
    {
        public int VehicleParkingId { get; set; }
        public int ParkingZoneId { get; set; }
        public int ParkingSpaceId { get; set; }
        public Nullable<System.DateTime> BookingDateTime { get; set; }
        public Nullable<System.DateTime> ReleaseDateTime { get; set; }
        public string VehicleRegistrationNumber { get; set; }
    
        public virtual ParkingSpace ParkingSpace { get; set; }
        public virtual ParkingZone ParkingZone { get; set; }
    }
}