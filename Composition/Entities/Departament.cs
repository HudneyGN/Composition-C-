using System;
using System.Collections.Generic;
using System.Globalization;
using Composition.Entities;
using Composition.Entities.Enums;
;

namespace Composition.Entities {
    class Department {
        public string Name { get; set; }

        public Department() {
        }

        public Department(string name) {
            Name = name;
        }
    }
    
}
