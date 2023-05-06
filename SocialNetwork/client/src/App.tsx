import React, { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";

function App() {
  const [activeness, setActiveness] = useState();
  useEffect(() => {
    axios.get("http://localhost:11333/api/Activeness").then((Response) => {
      console.log(Response);
      setActiveness(Response.data);
    });
  }, []);

  return (
    <div className="App">
      <header className="App-header"></header>
    </div>
  );
}

export default App;
