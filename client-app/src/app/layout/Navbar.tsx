import React from 'react'

const Navbar = () => {
  return (
    <div className='flex flex-row items-center border-b-2 py-2 px-2'>
      <div className='mr-32'>
         <h1 className='font-bold text-2xl'>Eventsocity</h1>
      </div>

      <div className='flex flex row lg:basis-1/6 sm:basis-1/4 items-center'>
         <div className='basis-1/2'>
            <h1 className='font-semibold'>Events</h1>
         </div>
         <div className='basis-1/2 items-center'>
            <button 
               className='font-semibold bg-sky-500 hover:bg-sky-700 rounded-lg px-2 py-2 transform hover:scale-125 transition duration-500 ease-in-out'>
                  Create Event
            </button>
         </div>
      </div>
    </div>
  )
}

export default Navbar