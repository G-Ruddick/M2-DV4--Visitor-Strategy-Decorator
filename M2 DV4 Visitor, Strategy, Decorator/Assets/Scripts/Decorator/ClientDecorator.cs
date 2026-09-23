using UnityEngine;

namespace Chapter.Decorator {
    public class ClientDecorator : MonoBehaviour {
        private BikeWeapon _bikeWeapon;
        private bool _isWeaponDecorated;

        void Start() {
            _bikeWeapon = (BikeWeapon)FindAnyObjectByType(typeof(BikeWeapon));
        }

        void OnGUI() {
            if (!_isWeaponDecorated)
                if (GUI.Button(new Rect(0, 130, 120, 25), "Decorate Weapon")) {
                    _bikeWeapon.Decorate();
                    _isWeaponDecorated = !_isWeaponDecorated;
                }
            if (_isWeaponDecorated)
                if (GUI.Button(new Rect(0, 130, 120, 25), "Reset Weapon")) {
                    _bikeWeapon.Reset();
                    _isWeaponDecorated = !_isWeaponDecorated;
                }

            if (GUI.Button(new Rect(0, 165, 100, 30), "Toggle Fire"))
                _bikeWeapon.ToggleFire();
        }
    }
}
