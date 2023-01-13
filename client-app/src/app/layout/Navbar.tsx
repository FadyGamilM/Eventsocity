import React from "react";

const Navbar = () => {
	return (
		<div className="flex flex-row items-center border-b-2 py-2 px-8">
			<div className="mr-32 flex flex-row items-center">
				<img
					className="w-20"
					src="../../../assets/app-logo.png"
					alt="hello world"
				/>
				<h1 className="text-sky-900 font-bold text-2xl">Eventsocity</h1>
			</div>

			<div className="flex flex-row basis-1/4 items-center">
				<div className="basis-1/3">
					<h1 className="font-semibold hover:text-blue-700 cursor-pointer transition ease-in-out">
						Events
					</h1>
				</div>
				<div className="basis-2/3 items-center">
					<button className="font-semibold bg-sky-500 hover:bg-sky-700 rounded-lg px-2 py-2 transform hover:scale-125 transition duration-500 ease-in-out">
						Create Event
					</button>
				</div>
			</div>
		</div>
	);
};

export default Navbar;
