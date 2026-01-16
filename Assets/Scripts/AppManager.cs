using System.Collections.Generic;
using UnityEngine;
using dev.xrlab.ui;

namespace dev.xrlab.core
{
    public class AppManager : MonoBehaviour
    {
        private readonly Dictionary<AppStateId, AppState> states = new();
        private AppState current;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            BuildStatesFromViews();
            GoTo(AppStateId.Welcome);
        }

        private void BuildStatesFromViews()
        {
            var views = FindObjectsOfType<UIView>(true);

            foreach (var view in views)
            {
                var state = new AppState(view.StateId, view);
                states[state.Id] = state;
                view.Hide();
            }
        }

        public void GoTo(AppStateId id)
        {
            if (!states.TryGetValue(id, out var next))
                return;

            current?.Exit();
            current = next;
            Debug.Log($"[AppManager] State -> {id}");
            current.Enter();
        }
    }
}