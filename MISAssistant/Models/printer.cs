//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MISAssistant.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class printer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public printer()
        {
            this.cart_transaction = new HashSet<cart_transaction>();
        }
    
        public int id { get; set; }
        public string department { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public string vender { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string ip { get; set; }
        public string cartridge_black { get; set; }
        public string cartridge_blue { get; set; }
        public string cartridge_red { get; set; }
        public string cartridge_yellow { get; set; }
        public string note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cart_transaction> cart_transaction { get; set; }
    }
}
