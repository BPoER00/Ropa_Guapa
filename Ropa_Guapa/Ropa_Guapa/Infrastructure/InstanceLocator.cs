﻿
namespace Ropa_Guapa.Infrastructure
{
    using ViewModels;

    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
    
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }

    }
}
