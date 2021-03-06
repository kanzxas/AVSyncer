﻿using System;

namespace SSWSyncer.Commands {

    [Serializable]
    class LogoutCommand : AbstractCommand {

        public override void Invoke (bool isSimulate, bool async) {
            log.Debug(this.ToString());
            StateContainer.Logout();
            if (isSimulate) {
                sim.Mouse.MoveMouseTo(1000 * xf, 765 * yf).Sleep(500).LeftButtonClick().Sleep(1500);
                sim.Mouse.MoveMouseTo(184 * xf, 672 * yf).Sleep(500).LeftButtonClick().Sleep(500);
            }
        }

        public override string ToString () {
            return "登出";
        }

    }
}
