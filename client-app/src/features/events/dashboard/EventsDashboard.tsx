import React from "react";
import { Event } from "../../../app/models/Event";
import EventList from "./EventList";
import EventDetails from "../details/EventDetails";

interface Props {
	events: Event[];
}

const EventsDashboard = ({ events }: Props) => {
	return (
		<div className="flex flex-row">
			<div className="basis-2/3 bg-sky-500">
				<EventList events={events} />
			</div>
			<div className="basis-1/3">
				{events[0] && <EventDetails event={events[0]} />}
			</div>
		</div>
	);
};

export default EventsDashboard;
