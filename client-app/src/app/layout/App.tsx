import React, { useEffect, useState } from "react";
import axios from "axios";
import { Event } from "../models/Event";
import Navbar from "./Navbar";
import EventsDashboard from "../../features/events/dashboard/EventsDashboard";

function App() {
	const [events, setEvents] = useState<Event[]>([]);

	useEffect(() => {
		axios.get<Event[]>("http://localhost:5100/api/events").then((res) => {
			setEvents(res.data);
			console.log(res.data);
		});
	}, []);

	return (
		// the parent div
		<div className="flex place-content-center">
			<div className="bg-sky-500 rounded-full w-auto">hello</div>
		</div>
		// <div className="App">
		// 	<Navbar />
		// 	<div>
		// 		<EventsDashboard events={events} />
		// 	</div>
		// </div>
	);
}

export default App;
