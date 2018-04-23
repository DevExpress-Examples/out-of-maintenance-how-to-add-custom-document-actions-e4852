using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.ViewModels {
    public class ViewModelModuleB {
        public bool Flag { get; set; }
        
        public bool IsSpecificState { get; set; }
        public void SetSpecicState() {
            IsSpecificState = true;
        }
        public void ResetSpecificState() {
            IsSpecificState = false;
        }
    }
}
