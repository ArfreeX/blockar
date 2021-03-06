﻿using UnityEngine;
using VirtualObjects;

namespace Controls
{
    public class VirtualObjectTouchHandler
    {
        private readonly VirtualObjectsManager virtualObjectsManager;
        private readonly IController controller;

        public VirtualObjectTouchHandler(VirtualObjectsManager virtualObjectsManager, IController controller)
        {
            this.virtualObjectsManager = virtualObjectsManager;
            this.controller = controller;
        }

        public void OnVirtualObjectTap(RaycastHit hit)
        {
            controller.HandleNonUITouch();
            virtualObjectsManager.HandleNewObject(hit);
        }

        public void OnVirtualObjectHold(RaycastHit hit)
        {
            var gameObject = virtualObjectsManager.HandleSelection(hit);
            controller.HandleObjectSelection(gameObject);
        }
    }
}
