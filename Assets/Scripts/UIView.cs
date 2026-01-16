using UnityEngine;

namespace dev.xrlab.ui
{
    public class UIView : MonoBehaviour
    {
        [SerializeField] private dev.xrlab.core.AppStateId stateId;
        public dev.xrlab.core.AppStateId StateId => stateId;

        public void Show() => gameObject.SetActive(true);
        public void Hide() => gameObject.SetActive(false);
    }
}
