using Server.Commands;
using System;
using Server;
using Server.Network;
using Server.Targeting;
using Server.Mobiles;
using Server.Items;

namespace Server.Commands
{
    public class LinkTeleporterCommand
    {
        public static void Initialize()
        {
            CommandSystem.Register("telelink", AccessLevel.GameMaster, new CommandEventHandler(LinkTeleporter_OnCommand));
        }

        [Usage("telelink")]
        [Description("Creates 2 teleporters simultaneously and links them.")]

        private static void LinkTeleporter_OnCommand(CommandEventArgs e)
        {
            Mobile from = e.Mobile;      

            from.SendMessage("Target a location for 1st Teleporter:");
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

                Point3D tele_Loc1 = new Point3D(p);
                Map tele_Map1 = from.Map;                

                from.SendMessage("Target a location for 2nd Teleporter:");
                from.Target = new SecondTarget(tele_Loc1, tele_Map1);
            }
        }

        private class SecondTarget : Target
        {
            private Point3D tele_Loc1;
            private Map tele_Map1;

            public SecondTarget(Point3D loc, Map map) : base(-1, true, TargetFlags.None)
            {
                tele_Loc1 = loc;
                tele_Map1 = map;
            }

            protected override void OnTarget(Mobile from, object target)
            {
                IPoint3D p = target as IPoint3D;

                if (p == null)
                    return;

                Point3D tele_Loc2 = new Point3D(p);
                Map tele_Map2 = from.Map;

                Item tele1 = new Teleporter(tele_Loc2, tele_Map2);
                Item tele2 = new Teleporter(tele_Loc1, tele_Map1);

                tele1.MoveToWorld(tele_Loc1, tele_Map1);
                tele2.MoveToWorld(tele_Loc2, tele_Map2);                
            }
        }        	
    }    
}