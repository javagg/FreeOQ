using System;
using CleverQuant.Shared;
using CleverQuant.Projects;

namespace CleverQuant
{
	class Global : CleverQuant.Shared.Global
    {
        public Global()
        {
        }

		public static ProjectManager ProjectManager
		{
			get
			{
				return Global.GetObject<ProjectManager>();
			}
			set
			{
				Global.SetObject(value);
			}
		}
    }
}

