import React from "react";
import { Event } from "../../../app/models/Event";
interface Props {
	events: Event[];
}
const EventList = ({ events }: Props) => {
	return (
		<>
			<div className="grid gap-y-4 grid-cols-1 m-5 p-10">
				{events.map((event) => (
					<div key={event.id} className="border-2 p-4 flex flex-row rounded-lg">
						<div className="basis-5/6">
							<h1 className="font-bold text-xl">{event.title}</h1>
							<h1 className="font-light">{event.date}</h1>
							<h1 className="font-semibold">{event.description}</h1>
							<h1 className="font-bold">
								{event.city}, {event.venue}
							</h1>
							<button className="m-2 p-2 rounded-lg bg-sky-500 hover:bg-sky-700 font-bold transform duration-500 transition ease-in-out hover:scale-125">
								View
							</button>
						</div>
						<div className=" basis-1/6 p-2 border-2 rounded-lg box-border h-10 flex justify-center">
							{event.category}
						</div>
					</div>
				))}
			</div>
		</>
	);
};

export default EventList;
