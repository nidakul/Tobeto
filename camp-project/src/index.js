import React from "react";
import "./index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import { BrowserRouter } from "react-router-dom";
import ReactDOM from "react-dom";
import { Provider } from "react-redux";
import { configureStore } from "./store/configureStore";
import "react-toastify/dist/ReactToastify.min.css"

const store = configureStore()
ReactDOM.render(
    <Provider store={store}>
        <BrowserRouter>
    <App />
  </BrowserRouter>
    </Provider>, 
  
  document.getElementById("root")
);
//const root = createRoot(document.getElementById('root'));
//root.render(<App />);
// root.render(
//    <React.StrictMode>
//     <App />
//    </React.StrictMode>
//   );

// const rootElement = document.getElementById('root');
// const root = createRoot(rootElement);
// root.render(
//   <Router>
//     <App />
//   </Router>
// );
reportWebVitals();
