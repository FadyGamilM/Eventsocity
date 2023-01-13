import React from "react";
import { Event } from "../../../app/models/Event";

interface Props {
	event: Event;
}

const EventDetails = ({ event }: Props) => {
	return (
		<div className="justify-center flex m-10">
			<div className="p-5 border-2 max-w-sm">
				<a href="../../../../../assets/categoryImages/fun.jpg">
					<img
						src="../../../../../assets/categoryImages/fun.jpg"
						alt="category image"
					/>
				</a>
				<h1 className="font-bold text-2xl">{event.title}</h1>
				<h1 className="font-light">{event.date}</h1>
				<h1 className="text-sky-800 font-semibold">{event.description}</h1>
				<div className="flex flex-row ">
					<button className="basis-1/2 border-2 rounded-lg bg-red-500 justify-center flex box-border h-7 w-7 items-center">
						Edit
					</button>
					<button className="basis-1/2 border-2 rounded-lg bg-sky-500 flex justify-center">
						Cancel
					</button>
				</div>
			</div>
		</div>
	);
};

export default EventDetails;
