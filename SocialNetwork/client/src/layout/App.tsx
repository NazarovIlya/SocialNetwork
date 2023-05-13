import React, { useEffect, useState } from "react";
import "./style.css";
import axios from "axios";
import { ActivenessItem } from "../components/activeness/ActivenessItem";
import { Activeness } from "../model/Activeness";
import { Button, Header } from "semantic-ui-react";

function App() {
  const [activeness, setActiveness] = useState<Activeness[]>([]);
  useEffect(() => {
    axios
      .get<Activeness[]>("http://localhost:11333/api/Activeness")
      .then((Response) => {
        setActiveness(Response.data);
      });
  }, []);

  return (
    <div>
      <Header as="h1">
        <img src="images/logo.png" alt="logo" />
        <label>Social Network project</label>
      </Header>
      {activeness.map((e) => (
        <div key={e.id}>
          <ActivenessItem activenessItem={e} />
        </div>
      ))}
    </div>
  );
}

export default App;
