import React, { useEffect, useState } from 'react';
import axios from "axios";

function App() {
  const [events, setEvents] = useState([]);

  useEffect(()=>{
    axios.get("http://localhost:5000/api/events").then(response => 
    {
      setEvents(response.data);
      console.log(response.data);
    });
  }, []);
  return (
    <div className="App">
      {
        events.map(
          (event : any) => (
            <div key={event.id}>
              <h1>{event.title}</h1>
            </div>
          )
        )
      }
    </div>
  );
}

export default App;
