﻿
namespace Component_Game.Components {
    //Causes the player to wrap around to the other side of the map.
    class KeepInBoundsComponent : Component {

        public override void Update() {
            if ( Container.X > 11 ) {
                Container.X = -11;
            }
            if ( Container.X < -11 ) {
                Container.X = 11;
            }
            if ( Container.Y > 8 ) {
                Container.Y = -8;
            }
            if ( Container.Y < -8 ) {
                Container.Y = 8;
            }
        }
    }
}
