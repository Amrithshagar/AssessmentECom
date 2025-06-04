import {
  createBrowserRouter,
  RouterProvider,
} from "react-router";
const router = createBrowserRouter([
  {
    path: "/",
    element: <Root />,
    loader: rootLoader,
    children: [
      {
        path: "team",
        element: <Team />,
        loader: teamLoader,
      },
    ],
  },
]);
function App() {
  return <div className="app">
    <RouterProvider router={router} />
  </div>;
}

export default App;
