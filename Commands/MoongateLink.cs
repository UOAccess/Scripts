using Server.Commands;
using System;
using Server;
using Server.Network;
using Server.Targeting;
using Server.Mobiles;
using Server.Items;

namespace Server.Commands
{
    public class LinkMoongateCommand
    {
        public static int hue;

        public static void Initialize()
        {
            CommandSystem.Register("moongatelink", AccessLevel.GameMaster, new CommandEventHandler(LinkMoongate_OnCommand));
        }

        [Usage("moongatelink <hue>")]
        [Description("Creates 2 moongates simultaneously and links them.")]

        private static void LinkMoongate_OnCommand(CommandEventArgs e)
        {
            Mobile from = e.Mobile;
            hue = e.GetInt32(0);            

            from.SendMessage("Target a location for 1st Moongate:");
            from.Target = new FirstTarget();
        }
        
        private class FirstTarget : Target
        {          
            public FirstTarget() : base(-1, true, TargetFlags.None)
            {            
            }

            protected override void OnTarget(Mobile from, object target)
            {
                IPoint3D p = target as IPoint3D;                

                if (p == null)
                    return;

                Point3D mg_Loc1 = new Point3D(p);
                Map mg_Map1 = from.Map;                

                from.SendMessage("Target a location for 2nd Moongate:");
                from.Target = new SecondTarget(mg_Loc1, mg_Map1);
            }
        }

        private class SecondTarget : Target
        {
            private Point3D mg_Loc1;
            private Map mg_Map1;

            public SecondTarget(Point3D loc, Map map) : base(-1, true, TargetFlags.None)
            {
                mg_Loc1 = loc;
                mg_Map1 = map;
            }

            protected override void OnTarget(Mobile from, object target)
            {
                IPoint3D p = target as IPoint3D;

                if (p == null)
                    return;

                Point3D mg_Loc2 = new Point3D(p);
                Map mg_Map2 = from.Map;

                Item mg1 = new Moongate(mg_Loc2, mg_Map2);
                Item mg2 = new Moongate(mg_Loc1, mg_Map1);

                if (hue == null){
                    mg1.Hue = 0;
                    mg2.Hue = 0;
                }

                else{
                    mg1.Hue = hue;
                    mg2.Hue = hue;
                }                             

                mg1.MoveToWorld(mg_Loc1, mg_Map1);
                mg2.MoveToWorld(mg_Loc2, mg_Map2);                
            }
        }        	
    }    
}
