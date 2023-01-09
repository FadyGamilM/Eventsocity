import React, { useEffect, useState } from 'react';
import axios from "axios";
import { Event } from '../models/Event';
import Navbar from './Navbar';
function App() {
   const [events, setEvents] = useState<Event[]>([]);

   useEffect(()=>{
      axios.get("http://localhost:5100/api/events").then((res) => {
         setEvents(res.data);
         console.log(res.data);
      });
   }, []);
   return (
    <div className="App">
      <Navbar />
      <div>
         {
            events.map((event) => (
               <div key={event.id}>
                  <p>{event.title}</p>
               </div>
            ))
         }
         </div>
    </div>
  );
}

export default App;