﻿import React from 'react';
import Typing from 'react-typist';
import MediaIcon from "./MediaIcon";
import {MediaData} from "../data/MediaHandles";

export default function Home() {
	return (
		<div className={"d-flex justify-content-center align-items-center flex-column flex-grow-1"}>
			<div className={"display-1 flex-grow-1 d-flex align-items-center text-center"}>
				<Typing startDelay={500} cursor={{
					hideWhenDone: true
				}}>

					I am Berlm.

					<Typing.Backspace count={6} delay={750}/>
					<Typing.Delay ms={500}/>

					a programmer.

					<Typing.Backspace count={13} delay={500}/>
					<Typing.Delay ms={500}/>

					a designer.

					<Typing.Backspace count={11} delay={500}/>
					<Typing.Delay ms={500}/>

					a tech enthusiast.

					<Typing.Backspace count={27} delay={700}/>

					Welcome
				</Typing>
			</div>
			<div style={{width: "100px"}} className={"d-flex flex-row align-items-center justify-content-center"}>
				{
					MediaData.map((obj) =>
						<MediaIcon data={obj} key={obj.class}/>
					)
				}
			</div>
			<hr style={{width: "200px", height: "2px"}} className={"mb-3"} />
		</div>
	);
}